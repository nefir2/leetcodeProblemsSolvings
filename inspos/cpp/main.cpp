#include <iostream>
#include <vector>
#include <cassert>

class Solution {
public:
	int searchInsert(std::vector<int>& nums, int target) {
		size_t left{};
		size_t right{nums.size()};
		size_t mid;
		if (nums.size() == 1) return target <= nums[0] ? 0 : 1;
		while (true) {
			mid = ((right + left) / 2);
			if (left + 1 == right) return target <= left ? left : right;
			else if (target < nums[mid]) {
				right = mid;
				continue;
			}
			else if (target > nums[mid]) {
				left = mid;
				continue;
			}
			else if (target == nums[mid]) return mid;
		}
	}
};

int main(int argc, char** argv) {
	std::vector<int> array {2, 3, 4, 8}; //1, 3, 4, 5, 6, 7, 9, 10
	Solution sol{};
	size_t pos = sol.searchInsert(array, 2);
	//assert(pos == 0);
	for (const int& e : array) std::cout << e << ' ';
	std::cout << "\npos : " << pos << "\narray[pos] : " << array[pos] << std::endl;
	return 0;
}