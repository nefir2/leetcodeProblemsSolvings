#include <iostream>
#include "solution.h"

int main(void) {
	Solution sol;
	std::vector vec {0, 1, 0, 3, 12};
	sol.moveZeroes(vec);
	//for (unsigned i = 0; i < vec.size(); i++) std::cout << vec[i] << ' ';
	return 0;
}