#include <iostream>
#include <iomanip>

int main()
{
	int monthly_income;
	float monthly_tax;

	std::cout << "The monthly income is ";
	std::cin >> monthly_income;

	if (monthly_income < 1000) {

		monthly_tax = (0.0 * monthly_income);
		std::cout << "S/He will not pay any tax." << std::endl;
		std::cout << std::fixed << std::setprecision(2) << monthly_tax << " TL.";
	}
	else if (monthly_income >= 1000 && monthly_income < 3000) {

		monthly_tax = (0.1 * monthly_income);
		std::cout << "S/He should pay " << std::fixed << std::setprecision(2) << monthly_tax << " TL.";
	}
	else {

		monthly_tax = (0.15 * monthly_income);
		std::cout << "S/He should pay " << std::fixed << std::setprecision(2) <<  monthly_tax << " TL.";
	}

	std::cout << std::endl << "You have to do it for living free in this country. :D" << std::endl;

	return 0;
}
