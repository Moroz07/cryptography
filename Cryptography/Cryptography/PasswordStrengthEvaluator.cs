using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class PasswordStrengthEvaluator
    {
        // Проверяет наличие русских букв в пароле
        private bool IsRussianSymbol(string password)
        {
            foreach (char c in password)
                if (CaesarCipher.russianAlphabet.Contains(c) || CaesarCipher.russianUpper.Contains(c))
                {
                    return true;
                }
            return false;
        }

        // Проверяет наличие английских букв в пароле
        private bool IsEnglishSymbol(string password)
        {
            foreach (char c in password)
                if (CaesarCipher.englishAlphabet.Contains(c) || CaesarCipher.englishUpper.Contains(c))
                {
                    return true;
                }
            return false;
        }

        // Проверяет наличие цифр в пароле
        private bool IsNumbers(string password)
        {
            foreach (char c in password)
                if (CaesarCipher.numbers.Contains(c))
                {
                    return true;
                }
            return false;
        }

        // Проверяет наличие спецсимволов в пароле
        private bool IsSpecialSymbol(string password)
        {
            foreach (char c in password)
                if (CaesarCipher.Specials.Contains(c))
                {
                    return true;
                }
            return false;
        }

        // Возвращает бонусные баллы за длину пароля
        private int GetLengthBonus(int length)
        {
            if (length >= 8 && length <= 11)
            {
                return 1;
            }
            if (length >= 12)
            {
                return 2;
            }
            return 0;
        }

        // Возвращает текстовый уровень надёжности по баллам
        private string GetScoreLevel(int score)
        {
            if (score <= 2)
            {
                return "очень слабый";
            }
            if (score == 3)
            {
                return "слабый";
            }
            if (score <= 5)
            {
                return "хороший";
            }
            return "очень надёжный";
        }


        // Оценивает пароль и возвращает результат (баллы, уровень, детали)
        public EvaluationResult Evaluate(string password)
        {
            if (password == null || password == "")
            {
                return new EvaluationResult(0, "нет данных", "Ошибка: нечего оценивать. Введите пароль");
            }

            int score = 0;
            bool hasRussian = false;
            bool hasEnglish = false;
            bool hasNumbers = false;
            bool hasSpecials = false;

            if (IsRussianSymbol(password))
            {
                score++;
                hasRussian = true;
            }
            if (IsEnglishSymbol(password))
            {
                score++;
                hasEnglish = true;
            }
            if (IsNumbers(password))
            {
                score++;
                hasNumbers = true;
            }
            if (IsSpecialSymbol(password))
            {
                score++;
                hasSpecials = true;
            }

            int bonus = GetLengthBonus(password.Length);
            score += bonus;

            string level = GetScoreLevel(score);
            string details = $"Русские: {(hasRussian ? "да (+1)" : "нет (0)")},\n " +
                             $"Английские: {(hasEnglish ? "да (+1)" : "нет (0)")},\n " +
                             $"Цифры: {(hasNumbers ? "да (+1)" : "нет (0)")},\n " +
                             $"Спецсимволы: {(hasSpecials ? "да (+1)" : "нет (0)")},\n " +
                             $"Длина ({password.Length}): +{bonus}";

            return new EvaluationResult(score, level, details);
        }
    }
}