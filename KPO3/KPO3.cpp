#include <iostream>
#include <conio.h>
using namespace std;

int Count(unsigned N, unsigned M, int** numbers)
{
	int counter = 0;
	for (unsigned i{}; i < N; i++)
	{
		for (unsigned j{}; j < M; j++)
		{
			int sum = 0;
			for (unsigned i2{}; i2 < N; i2++)
			{
				if (i2 == i) {
					continue;
				}
				else {
					sum += numbers[i2][j];
				}
			}
			if (sum <= numbers[i][j]) {
				counter++;
			}
		}
		cout << endl;
	}
	return counter;
}

void main()
{
	unsigned N;
	unsigned M;
	cout << "N,M = ";
	cin >> N >> M;

	// Инициализация массива
	int** numbers{ new int* [N] {} };
	for (unsigned i{}; i < N; i++)
	{
		numbers[i] = new int[M] {};
	}

	// Заполнение массива
	for (unsigned i{}; i < N; i++)
	{
		cout << "Enter data for " << (i + 1) << " row" << endl;
		for (unsigned j{}; j < M; j++)
		{
			cout << (j + 1) << " column: ";
			cin >> numbers[i][j];
		}
	}

	// Подсчёт и вывод результата
	int result = Count(N, M, numbers);
	cout << "amount unique items = " << result << "\n";
	system("pause");
}