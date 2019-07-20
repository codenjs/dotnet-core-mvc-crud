var FizzBuzz = (function () {
    var _print = function (input) {
        var result = '';

        for (var i = 1; i <= input; i++)
        {
            if (i > 1)
                result += ', ';

            result += _generate(i);
        }

        return result;
    };

    var _generate = function (i) {
        if (i % 3 == 0 && i % 5 == 0)
            return 'FizzBuzz';
        else if (i % 3 == 0)
            return 'Fizz';
        else if (i % 5 == 0)
            return 'Buzz';
        else
            return i;
    };

    return function () {
        return {
            Print: _print
        };
    };
})();
