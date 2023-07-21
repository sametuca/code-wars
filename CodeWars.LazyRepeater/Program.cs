// See https://aka.ms/new-console-template for more information

/*
 The makeLooper() function (or make_looper in your language) takes a string (of non-zero length) as an argument. It returns a function. The function it returns will return successive characters of the string on successive invocations. It will start back at the beginning of the string once it reaches the end.

For example:

Func<char> abc = Kata.MakeLooper("abc");
abc(); // should return 'a' on this first call
abc(); // should return 'b' on this second call
abc(); // should return 'c' on this third call
abc(); // should return 'a' again on this fourth call
 
 */

Func<char> makeLooperFunc = MakeLooper("123");
var firstChar = makeLooperFunc();
var second = makeLooperFunc();
var third = makeLooperFunc();
Console.WriteLine($"First char {firstChar}\nSecond char {second}\nThird char {third}");
static Func<char> MakeLooper(string sequence)
{
    int index = 0;
    return () =>
    {
        char result = sequence[index];
        index = (index + 1) % sequence.Length;
        return result;
    };
}

