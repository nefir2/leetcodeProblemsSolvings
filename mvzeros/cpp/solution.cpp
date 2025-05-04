#include "solution.h"
#include <iostream>

void swap(std::vector<int>& array, const int& left_id, const int& right_id) {
	const int right_value = array[right_id];
	array[right_id] = array[left_id];
	array[left_id] = right_value;
}

void Solution::moveZeroes(std::vector<int>& nums) {
	if (nums.size() == 1) return;
	bool changed;
	do {
		changed = false;
		//for (unsigned i = 0; i < nums.size(); i++) std::cout << nums[i] << ' ';
		//std::cout << std::endl;
		for (int i = 0; i < nums.size(); i++) {
			if (nums[i] == 0 && !(i + 1 == nums.size() || nums[i + 1] == 0)) {
				swap(nums, i, i + 1);
				i++;
				changed = true;
			}
		}
	} while(changed);
}
/*
0 1 0 3 12
1 0 3 0 12
1 3 0 12 0
1 3 12 0 0
1 3 12 0 0
*/


/* лучшее решение на литкоде
void moveZeroes(vector<int>& nums) {
	int n = nums.size();
	int k = 0;
	for(int i=0;i<n;i++)
	{
		if(nums[i]!=0)
		{
			swap(nums[k++],nums[i]);
		}
	}
}

0 1 0 3 12 | k=0
1 0 0 3 12 | k=1
1 0 0 3 12 | k=1
1 3 0 0 12 | k=2
1 3 12 0 0 | k=3

я не понял почему это работает...
*/