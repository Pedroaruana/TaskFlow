import { getUserByEmail, verifyPassword } from "../../helpers/functions.helper";
import { AppError } from "../../middlewares/app.error";

export const loginService = async (email: string, password: string) => {

  const user = await getUserByEmail(email);
  if (!user) {
    throw new AppError("Invalid credentials", 401);
  }
  const isPasswordValid = await verifyPassword(password, user.password);
  if (!isPasswordValid) {
    throw new AppError("Invalid credentials", 401);
  };
  return user;
};
