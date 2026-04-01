import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private http = inject(HttpClient);
  private baseUrl = 'http://localhost:5279/api/exam';

  getQuestions() {
    return this.http.get(`${this.baseUrl}/quiz`);
  }

  submit(data: any) {
    return this.http.post(`${this.baseUrl}/submit`, data);
  }

  getResults() {
    return this.http.get(`${this.baseUrl}/results`);
  }

}

// import { Injectable } from '@angular/core';

// @Injectable({
//   providedIn: 'root',
// })
// export class Api {}
