#include "Square.h"

public ref class Cube : public Square
{
public:
	Cube(double side);

	double CountVolume();
	System::String^ Introduce() override;
	virtual double CountPerimeter() new;
	virtual double CountArea() new;
};