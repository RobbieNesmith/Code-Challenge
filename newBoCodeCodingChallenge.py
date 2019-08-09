def odometer(arr, change):
  pos = len(arr) - 1
  while pos >= 0 and change != 0:
    sum = arr[pos] + change
    if sum < 0:
      sum = sum - 10
    change = int(sum / 10)
    arr[pos] = sum % 10
    pos = pos - 1
  if change == 1:
    arr[0] = 1

tests = [{"input": [4,3,9,5], "output": [4,3,9,6]}, {"input": [4,3,4,9], "output": [4,3,5,0]}, {"input": [9,9,9,9], "output": [1,0,0,0]}]

for test in tests:
  testArr = []
  for i in range(len(test["input"])):
    testArr.append(test["input"][i])
  odometer(testArr, 1)
  valid = True
  for i in range(len(testArr)):
    if testArr[i] != test["output"][i]:
      valid = False
  if valid:
    print(f"Test succeeded! {test['input']} => {test['output']}")
  else:
    print(f"Test failed! Expected {test['output']}, got {testArr}")