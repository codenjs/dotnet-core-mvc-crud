/// <reference path="FizzBuzz.js" />

describe("FizzBuzz", function () {
    it("Should Print Text For Values That Are Multiples Of 3 And 5", function () {
        var fizzBuzzGenerator = new FizzBuzz();
        var result = fizzBuzzGenerator.Print(15);
        expect(result).toBe("1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz", result);
    });
});
