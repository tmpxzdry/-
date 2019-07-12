
var isHappy = function (n) {
    let flag = {};
    let sum = 0;

    while (!flag[n]) {
        flag[n] = true; //若结果从未出现过，就推送到对象里，标记为true

        sum=0;
        while (n > 0) {
            sum += Math.pow(n % 10, 2);
            n = parseInt(n / 10);
        }
        if (sum == 1) {
            return true;
        }
        n=sum;
    }
    return false;
};
let a = isHappy(89934);
console.log(a);