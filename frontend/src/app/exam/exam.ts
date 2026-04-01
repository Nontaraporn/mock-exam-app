import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ApiService } from '../services/api';
import { Router, NavigationEnd } from '@angular/router';
import { filter } from 'rxjs/operators';
import { ChangeDetectorRef } from '@angular/core';

@Component({
  selector: 'app-exam',
  standalone: true,
  imports: [CommonModule, FormsModule],
  templateUrl: './exam.html',
  styleUrl: './exam.css',
})
export class Exam implements OnInit {

  questions: any[] = [];
  answers: any[] = [];
  name = '';

  isLoading = true;

  constructor(
    private api: ApiService, 
    private router: Router,
    private cdr: ChangeDetectorRef
  ) {}

  ngOnInit() {
    this.loadQuestions();

    this.router.events
      .pipe(filter(event => event instanceof NavigationEnd))
      .subscribe(() => {
        this.loadQuestions();
      });
  }

  loadQuestions() {
    this.isLoading = true;

    this.api.getQuestions().subscribe({
      next: (res: any) => {

        this.questions = this.shuffle(res);
        this.answers = [];
        this.name = '';

        this.isLoading = false;
        this.cdr.detectChanges();
      },
      error: (err) => {
        console.error('API ERROR:', err);
        this.isLoading = false;
      }
    });
  }

  shuffle(array: any[]) {
    return array.sort(() => Math.random() - 0.5);
  }

  selectAnswer(qId: number, cId: number) {
    const existing = this.answers.find(x => x.QuizID === qId);

    if (existing) {
      existing.choiceId = cId;
    } else {
      this.answers.push({ QuizID: qId, ChoiceID: cId });
    }
  }

  submit() {
    this.api.submit({
      name: this.name,
      answers: this.answers
    }).subscribe((res: any) => {
      this.router.navigate(['/result'], {
        state: {
          name: this.name,
          score: res.score,
          total: res.total
        }
      });

    });
  }
}
