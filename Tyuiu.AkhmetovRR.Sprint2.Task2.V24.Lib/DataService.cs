﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.AkhmetovRR.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool Calculate(int x, int y)
        {
            bool inArea = (
            // Верхний левый квадрат
            ((y >= 2 && y <= 7) && (x >= 2 && x <= 5)) ||
            // Верхний правый квадрат
            ((x >= 8 && x <= 12) && (y >= 3 && y <= 6)) ||
            // Средняя полоса
            ((x >= 2 && x <= 13) && (y >= 5 && y <= 7)) ||
            // Нижний левый квадрат
            ((x >= 2 && x <= 5) && (y >= 10 && y <= 11)) ||
            // Нижний правый квадрат
            ((x >= 10 && x <= 12) && (y >= 8 && y <= 12)) ||
            // Центральный квадрат
            ((x >= 6 && x <= 8) && (y >= 8 && y <= 10)) ||
            // Квадрат между центральным и нижним правым
            ((x >= 9 && x <= 11) && (y >= 8 && y <= 10)) ||
            // Квадрат правее нижнего левого и ниже центрального
            ((x >= 5 && x <= 7) && (y >= 10 && y <= 11)) ||
            // Квадрат ниже всех центральный
            ((x >= 6 && x <= 7) && (y >= 11 && y <= 12)));
            return inArea;
        }

        bool ISprint2Task2V24.CheckDotInShadedArea(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
