#include <iostream>
#include <stdio.h>
#include <math.h>
using namespace std;
void  main()
{
	double x, t, res;
	cout << "x,t = ";
	cin >> x >> t;
	if (3 * t <= x && x < 10 * t) {
		res = sqrt(abs(x * pow(exp(1.0), sin(x)) + t * pow(exp(1.0), (-2) * x)));
		cout << "3 * t <= x && x < 10 * t";
	}
	else if (x >= 10 * t) {
		res = sqrt(abs(x + t) * pow(exp(1.0), cos(x)));
		cout << "x >= 10 * t";
	}
	else {
		cout << "Not a valid arguments!\n";
		system("pause");
		return;
	}
	cout << "\nRez = " << res;
	system("pause");
}