#include <iostream>
#include <vector>
#include <cassert>

class Solution {
public:
	std::vector<int> twoSum(const std::vector<int>& nums, const int& target) {
		for (int i = 0; i < nums.size(); i++) {
			for (int j = i + 1; j < nums.size(); j++) if (nums[i] + nums[j] == target) return std::vector<int> {i, j};
		}
		return std::vector<int> {};
	}
};

void test() {
	Solution sol = Solution();

	std::vector<int> example1 {1, 2, 3, 4};
	std::vector<int> ret = sol.twoSum(example1, 3);
	for (int i = 0; i < ret.size(); i++) std::cout << "ans [" << i << "]: " << ret[i] << std::endl;
}

int main() {
	test();
	return 0;
}