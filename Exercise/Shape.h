#pragma once

#include <string>
#include <math.h>

public ref class Shape
{
public: 
	virtual double CountPerimeter() = 0;
	virtual double CountArea() = 0;
	virtual System::String^ Introduce();
};