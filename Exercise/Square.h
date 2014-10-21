#pragma once
#include "Shape.h"

public ref class Square : public Shape
{
protected:
	double side;

public:
	Square(double side);

	virtual System::String^ Introduce() override;
	virtual double CountPerimeter() override;
	virtual double CountArea() override;
};