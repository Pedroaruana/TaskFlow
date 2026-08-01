import { BrowserRouter, Routes, Route, Navigate } from "react-router-dom";
import Login from './pages/login/signIn'
import Register from './pages/register/signUp'
import ForgotPassword from './pages/forgotPassword/forgotPassword'
import VerifyOtp from './pages/verifyOtp/verifyOtp'
import ResetPassword from './pages/resetPassword/resetPassword'

function App() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/" element={<Navigate to="/login" replace />} />
        <Route path="/login" element={<Login />} />
        <Route path="/register" element={<Register />} />
        <Route path="/esqueci-minha-senha" element={<ForgotPassword />} />
        <Route path="/verificar-otp" element={<VerifyOtp />} />
        <Route path="/resetar-senha" element={<ResetPassword />} />
      </Routes>
    </BrowserRouter>
  )
}

export default App
