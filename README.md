# 📝 Mock Exam App

A full-stack web application for taking quizzes, calculating scores, and storing results.  
Designed with a clean architecture using Angular + .NET 8 Web API.

---

## 🚀 Tech Stack

### Frontend
- Angular
- TypeScript
- Tailwind CSS (if used)

### Backend
- .NET 8 (C# Web API)
- Entity Framework Core

### Database
- SQLite

### Deployment
- Frontend: Vercel
- Backend: Render

---

## ✨ Features

- 🧠 Take a 10-question quiz (single choice per question)
- 📊 Automatic score calculation
- 💾 Save user name and score to database
- 📄 Display result after submission
- 📚 View exam history of all users
- 🔄 Reset and retake the quiz

---

## 🌐 Live Demo

- Frontend: https://mock-exam-app-kappa.vercel.app  
- Backend API: https://mock-exam-app-2.onrender.com/api/exam/quiz  

⚠️ **Note:**  
The backend is hosted on Render (Free Tier), which may cause a delay (cold start) on the first request.  
For the best experience, it is recommended to run the project locally.

---

## 🛠️ Getting Started

### 1. Clone Repository

```bash
git clone https://github.com/Nontaraporn/mock-exam-app.git
cd mock-exam-app
```

---

### 2. Run Backend

```bash
cd backend/MockTest
dotnet restore
dotnet run
```

Backend will start at:
```
http://localhost:8080/
```

---

### 3. Run Frontend

```bash
cd frontend
npm install
npm run dev
```

Frontend will start at:
```
http://localhost:4200
```

---

## 📡 API Endpoints

### Get Quiz
```http
GET /api/exam/quiz
```

### Submit Exam
```http
POST /api/exam/submit
Content-Type: application/json
```

#### Example Request

```bash
curl -X POST https://mock-exam-app-2.onrender.com/api/exam/submit \
-H "Content-Type: application/json" \
-d '{
  "name": "Test User",
  "answers": [
    { "QuizID": 1, "ChoiceID": 2 },
    { "QuizID": 2, "ChoiceID": 3 }
  ]
}'
```

---

## 📁 Project Structure

```
root/
│
├── backend/
│   └── MockTest/        # C# .NET 8 Web API
│
├── frontend/            # Angular App
│
└── README.md
```

---

## ⚙️ Notes

- This project is intended for learning and demonstration purposes
- Backend uses SQLite, so no additional DB setup is required
- You can easily switch to other databases (e.g., PostgreSQL, SQL Server)

---

## 📌 Future Improvements

- Authentication (Login/Register)
- Timer for quiz
- Randomized questions
- Pagination for history
- Better UI/UX

---

## 👨‍💻 Author

Developed by **[Nontaraporn Chanmaneewong]**  
Feel free to connect or give feedback 🙌

---
