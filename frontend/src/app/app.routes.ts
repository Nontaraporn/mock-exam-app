import { Routes } from '@angular/router';
import { Exam } from './exam/exam';
import { Result } from './result/result';

export const routes: Routes = [
  { path: '', component: Exam }, // Main page
  { path: 'result', component: Result }  // Second page
];
