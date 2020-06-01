print("The monthly income is ")
monthly_income = int(input())

if monthly_income < 1000:
    monthly_tax = (0.0 * monthly_income)
    print("S/He will not pay any tax.")
    print("{:.2f}".format(monthly_tax)+" TL.")

elif monthly_income >= 1000 and monthly_income < 3000:
    monthly_tax = (0.1 * monthly_income)
    print("S/He should pay {:.2f}".format(monthly_tax)+" TL.")

else:
    monthly_tax= (0.15 * monthly_income)
    print("S/He should pay {:.2f}".format(monthly_tax)+" TL.")

print("You have to do it for living free in this country. :D")
