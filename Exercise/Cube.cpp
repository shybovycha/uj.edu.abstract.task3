#include "Cube.h"

Cube::Cube(double side) : Square(side)
{
}

System::String^ Cube::Introduce()
{
	return "I'm a cube.";
}

double Cube::CountVolume()
{
	return pow(this->side, 3.0);
}

double Cube::CountArea()
{
	return 6.0 * Square::CountArea();
}

double Cube::CountPerimeter()
{
	return 12.0 * this->side;
}
