const countWine = (wineInit = 0, capCount = 0, bottleCount = 0) => {
  console.log(`本轮酒数：${wineInit},酒瓶数：${bottleCount},瓶盖数：${capCount}`);
  let remain, div;
  let wineCount = 0;
  if (wineInit == 0) return 0;

  capCount += wineInit;
  bottleCount += wineInit;

  if (capCount) {
    remain = capCount % 4;
    div = parseInt(capCount / 4);
    wineCount += div;
    capCount = remain;
  }
  if (bottleCount) {
    remain = bottleCount % 2;
    div = parseInt(bottleCount / 2);
    wineCount += div;
    bottleCount = remain;
  }

  wineInit += countWine(wineCount, capCount, bottleCount);
  return wineInit;
}

let result = countWine(5, 0, 0);
console.log(result);