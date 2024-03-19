let minMaxArr = [3, 5, 6, 7, 11];

function minMaxSum(numbers) {
  let i = 0,
    max = -Infinity,
    min = Infinity;
  while (i < numbers.length) {
    if (numbers[i] > max) {
      max = numbers[i];
    }
    if (numbers[i] < min) {
      min = numbers[i];
    }
    i++;
  }
  console.log(`The max number is ${max}`);
  console.log(`The min number is ${min}`);

  let results = max + min;
  return results;
}

let test = minMaxSum(minMaxArr);
console.log(`the sum of the min and max is ${test}`);