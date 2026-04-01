import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { ApiService } from '../services/api';
import { isPlatformBrowser } from '@angular/common';
import { inject, PLATFORM_ID } from '@angular/core';
import { ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'app-result',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './result.html',
  styleUrl: './result.css',
})
export class Result implements OnInit {
  constructor(
    private api: ApiService, 
    private router: Router,
    private cdr: ChangeDetectorRef
  ) {}
  
  platformId = inject(PLATFORM_ID);
  name = '';
  score = 0;
  total = 0;
  ngOnInit() {
    if (isPlatformBrowser(this.platformId)) {
      const state = history.state;
      if (state) {
        this.name = state.name;
        this.score = state.score;
        this.total = state.total;
      }
    }
  }

  back() {
    this.router.navigate(['/']);
  }

  allResults: any[] = [];
  isLoadingResults = false;

  loadAll() {
    this.isLoadingResults = true;

    this.api.getResults().subscribe((res: any) => {
      this.allResults = res;
      this.isLoadingResults = false;
      this.cdr.detectChanges();
    });
  }


  showModal = false;
  openModal() {
    this.showModal = true;
    this.loadAll();
  }

  closeModal() {
    this.showModal = false;
  }

  isPassed(r: any): boolean {
    return r.score >= r.total * 0.8;
  }
  
}