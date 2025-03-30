using findstrProj;

namespace findstrTests;

public class ExampleTests
{
    [Fact] public void Example1Test() => Assert.Equal(0, new Solution().StrStr("sadbutsad", "sad"));
    [Fact] public void Example2Test() => Assert.Equal(-1, new Solution().StrStr("leetcode", "leeto"));
    [Fact] public void MyOwnTest1() => Assert.Equal(12, new Solution().StrStr("someleetcodeleeto", "leeto"));
    [Fact] public void MyOwnTest2() => Assert.Equal(-1, new Solution().StrStr("sabutsa", "sad"));

}
