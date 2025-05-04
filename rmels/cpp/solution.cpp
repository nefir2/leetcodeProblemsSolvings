#include "solution.h"

void swap(std::vector<int>& array, const int& left_element_id, const int& right_element_id) {
	const int right_element_value = array[right_element_id];
	array[right_element_id] = array[left_element_id];
	array[left_element_id] = right_element_value;
}

int Solution::removeElement(std::vector<int>& nums, const int& val) {
	unsigned short size {static_cast<unsigned short>(nums.size())};
	for (unsigned short i = 0; i < size; i++) {
		if (nums[i] == val) {
			swap(nums, i, --size);
			i--;
		}
	}
	return static_cast<int>(size);
}
/*
1 2 3 4 | 1
_ 2 3 4
4 2 3 _
*/