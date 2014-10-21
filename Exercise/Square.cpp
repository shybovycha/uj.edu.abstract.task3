#include "Square.h"

Square::Square(double side)
{
	this->side = side;
}

System::String^ Square::Introduce()
{
	return "I'm a square.";
}

double Square::CountArea()
{
	return pow(this->side, 2.0);
}

double Square::CountPerimeter()
{
	return 4.0 * this->side;
}