import { getUserByEmail } from "../../helpers/functions.helper";
import { AppError } from "../../middlewares/app.error";

export const forgotPasswordService = async (email: string) => {

  const user = await getUserByEmail(email);

  if (!user) {
    throw new AppError("Email not found.", 404);
  }
  
  return user;
};
