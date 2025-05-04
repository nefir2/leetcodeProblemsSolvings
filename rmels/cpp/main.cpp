#include <iostream>
#include "solution.h"

int main(void) {
	std::vector<int> nums {3, 2, 2, 3};
	Solution sol;
	auto count = sol.removeElement(nums, 3);
	return 0;
}