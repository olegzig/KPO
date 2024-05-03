#include <iostream>
#include <conio.h>
#include <math.h>
int main()
{
	double x, y, z, a, b, c, rez;
	std::cout << "x,y,z = ";
	std::cin >> x >> y >> z;
	a = pow(2, pow(y, x)) + pow(pow(3, x), y);
	b = y * (atan(z) - acos(-1.0) / 6);
	c = abs(x) + (1 / (pow(y,2) + 1));
	rez = a - b / c;
	std::cout << "\n x = " << x << "\n y = " << y << "\n z = " << z
		<< "\nRezult = " << rez << std::endl;
	system("pause");
	return 0;
}