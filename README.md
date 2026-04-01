# Mock Exam App

## Tech Stack
- Frontend: Angular
- Backend: .NET 8 (C#)
- Database: SQLite

## Features
- Take a 10-question quiz
- Save scores to the database
- Display the quiz results
- View user exam history

## Run

### Backend
- ```cd backend/MockTest```
- ```dotnet run```

### Frontend
- ```cd frontend```
- ```npm install```
- ```npm run dev```


## Live Demo
Frontend: https://mock-exam-app-kappa.vercel.app

Backend API: https://mock-exam-app-2.onrender.com/api/exam/quiz
### Add on
CDM : ```curl -X POST https://mock-exam-app-2.onrender.com/api/exam/submit -H "Content-Type: application/json" -d "{\"name\":\"Test User\",\"answers\":[{\"QuizID\":1,\"ChoiceID\":2},{\"QuizID\":2,\"ChoiceID\":3}]}"```
