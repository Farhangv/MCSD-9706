//let names = new Array();
let names = ['C#', 'Java'];

console.log(names[0]);
names[2] = "PHP"; 

names.push('Python');
names.push('Ruby');
names.push('TypeScript');
names.unshift('C++');


console.log(`pop(): ${names.pop()}`);
console.log(`shift(): ${names.shift()}`);

names.splice(2, 1, "R", "Go");


console.log('------------------------');
for (var i = 0; i < names.length; i++) {
    console.log(names[i]);
}

console.log('------------------------');
for (let ix in names) {
    console.log(`[${ix}] : ${names[ix]}`);
}

console.log('------------------------');
for (let name of names) {
    console.log(name);
}

console.log('------------------------');
console.log(typeof names);
console.log(names instanceof Array);
console.log(Array.isArray(names));

console.log('------------------------');
console.log(names.join(','));