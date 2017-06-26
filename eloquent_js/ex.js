for (var i=0;i<7;i++)
{
	for (var j=0;j<i+1;j++)
		console.log("# ");
	console.log("\n");
}

/*for(var i=1;i<100;i++){
	if (i%3 === 0) console.log('Fizz');
	else if (i%5 === 0) console.log('Buzz');
	else console.log(i);
}*/

for(var i=1;i<=100;i++){
	if (i%3 === 0 && i%5 === 0) console.log('FizzBuzz');
	else if (i%3 === 0) console.log('Fizz');
	else if (i%5 === 0) console.log('Buzz');
	else console.log(i);
}

var size=16;
var str="";
for (var i=1;i<=size;i++)
{
	for (var j=1;j<=size;j++)
	{
		if (i%2 === 0 && j%2 === 1) str+=" ";
		else if (i%2 === 1 && j%2 === 0) str+=" ";
		else str+="#";
	}
	str+="\n";
}
console.log(str);

/*---------------------------------ФУНКЦИИ---------------------------------------*/
function min(a, b){
	if (a<b) return a;
	else return b;
}
console.log(min(0,10));
console.log(min(0,-10));

function isEven(num){
	if (num===0) return true;
	else if (num===1) return false;
	else if (num<0) return isEven(-num);
	else return isEven(num-2);
}
console.log(isEven(50));
console.log(isEven(75));
console.log(isEven(-10));

function countChar(string, char){
	var num = 0;
	for (var i=0;i<string.length;i++){
		if (string.charAt(i)===char) num++;
	}
	return num;
}
function countBs(string){
	return countChar(string, 'B');
}
console.log(countBs("BBC"));
console.log(countChar("kakkerlak", "k"));
console.log(countChar("лалалыа", "о"));

/*---------------Структуры данных: объекты и массивы----------------*/
/*function range(start, end){
	var array = [];
	for (var i=start;i<=end;i++)
		array.push(i);
	return array;
}
console.log(range(1,10));*/

function range(start, end, step){
	var array = [];
	if (arguments.length<3) step=1;
	if (step===0) return array;
	else if (step>0)
	{
		for (var i=start;i<=end;i+=step)
		array.push(i);
	}
	else
	{
		for (var i=start;i>=end;i+=step)
		array.push(i);
	}
	return array;
}
console.log(range(2, 8));
console.log(range(1, 10, 2));
console.log(range(2, 10, 2));
console.log(range(5, 2, -1));

function sum(array){
	var sum = 0;
	for (var i=0; i<array.length; i++)
		sum+=array[i];
	return sum;
}
console.log(sum(range(1, 10)));

function reverseArray(array){
	var newArray=[];
	for (var i=array.length-1;i>=0;i--)
		newArray.push(array[i]);
	return newArray;
}
console.log(reverseArray(["A", "B", "C"]));

function reverseArrayInPlace(array){
	for(var i=0;i<array.length/2;i++)
	{
		var elemStart=array[i], elemEnd=array[array.length-1-i];
		array[i] = elemEnd;
		array[array.length-1-i] = elemStart;
	}
	return array;
}

var arrayValue = [1, 2, 3, 4, 5];
reverseArrayInPlace(arrayValue);
console.log(arrayValue);

function arrayToList(array)
{
	var list=null;
	for (var i=array.length-1; i>=0;i--)
		list = { value: array[i], rest: list};
	return list;
}
console.log(arrayToList([10, 20, 30]));

function listToArray(list){
	var array=[];
	for(var node=list; node; node=node.rest)
		array.push(node.value);
	return array;
}
console.log(listToArray(arrayToList([10, 20, 30])));

function prepend(value, list){
	var newList = {value: value, rest: list};
	return newList;
}
console.log(prepend(10, prepend(20, null)));

/*function nthNotRec(list, index){
	var i=0;
	for (var node=list;node;node=node.rest){
		if (i===index) return node.value;
		else i++;
	}
	return undefined;
}
console.log(nthNotRec(arrayToList([10, 20, 30]), 2));*/

function nth(list, index){
	if(!list)
		return undefined;
	else if(index==0)
		return list.value;
	else 
		return nth(list.rest, index-1);
}
console.log(nth(arrayToList([10, 20, 30]), 6));

function deepEqual(a, b){
	if (a===b) return true;

	//typeof null вернёт object
	if (a==null || b==null || typeof a!="object" || typeof b!="object")
		return false;

	var numPropsA=0, numPropsB=0;
	for (var prop in a) //перебор всех свойств в объекте a
		numPropsA++;
	for (var prop in b)
	{
		numPropsB++;
		//если нет такого же свойства в a, или значения свойств не равны
		if (!(prop in a) || !deepEqual(a[prop], b[prop]))
			return false;
	}
	return numPropsA===numPropsB;
}
var obj = {here: {is: "an"}, object: 2};
console.log(deepEqual(obj, obj));
console.log(deepEqual(obj, {here: 1, object: 2}));
console.log(deepEqual(obj, {here: {is: "an"}, object: 2}));

/*-------------------ФУНКЦИИ ВЫСШЕГО ПОРЯДКА--------------------*/
var arrays = [[1, 2, 3], [4, 5], [6]];
console.log(arrays.reduce(function(prev, cur){
	return prev.concat(cur);
}, []));
/*Метод «arr.reduce(callback[, initialValue])» используется для 
последовательной обработки каждого элемента массива с сохранением
промежуточного результата.
Он применяет функцию callback по очереди к каждому элементу массива
слева направо, сохраняя при этом промежуточный результат.
Аргументы функции callback(previousValue, currentItem, index, arr):
previousValue – последний результат вызова функции, он же 
«промежуточный результат», currentItem – текущий элемент массива,
элементы перебираются по очереди слева-направо, index – номер текущего
элемента, arr – обрабатываемый массив.*/

var ANCESTRY_FILE = JSON.stringify([
  {"name": "Carolus Haverbeke", "sex": "m", "born": 1832, "died": 1905, "father": "Carel Haverbeke", "mother": "Maria van Brussel"},
  {"name": "Emma de Milliano", "sex": "f", "born": 1876, "died": 1956, "father": "Petrus de Milliano", "mother": "Sophia van Damme"},
  {"name": "Maria de Rycke", "sex": "f", "born": 1683, "died": 1724, "father": "Frederik de Rycke", "mother": "Laurentia van Vlaenderen"},
  {"name": "Jan van Brussel", "sex": "m", "born": 1714, "died": 1748, "father": "Jacobus van Brussel", "mother": "Joanna van Rooten"},
  {"name": "Philibert Haverbeke", "sex": "m", "born": 1907, "died": 1997, "father": "Emile Haverbeke", "mother": "Emma de Milliano"},
  {"name": "Jan Frans van Brussel", "sex": "m", "born": 1761, "died": 1833, "father": "Jacobus Bernardus van Brussel", "mother":null},
  {"name": "Pauwels van Haverbeke", "sex": "m", "born": 1535, "died": 1582, "father": "N. van Haverbeke", "mother":null},
  {"name": "Clara Aernoudts", "sex": "f", "born": 1918, "died": 2012, "father": "Henry Aernoudts", "mother": "Sidonie Coene"},
  {"name": "Emile Haverbeke", "sex": "m", "born": 1877, "died": 1968, "father": "Carolus Haverbeke", "mother": "Maria Sturm"},
  {"name": "Lieven de Causmaecker", "sex": "m", "born": 1696, "died": 1724, "father": "Carel de Causmaecker", "mother": "Joanna Claes"},
  {"name": "Pieter Haverbeke", "sex": "m", "born": 1602, "died": 1642, "father": "Lieven van Haverbeke", "mother":null},
  {"name": "Livina Haverbeke", "sex": "f", "born": 1692, "died": 1743, "father": "Daniel Haverbeke", "mother": "Joanna de Pape"},
  {"name": "Pieter Bernard Haverbeke", "sex": "m", "born": 1695, "died": 1762, "father": "Willem Haverbeke", "mother": "Petronella Wauters"},
  {"name": "Lieven van Haverbeke", "sex": "m", "born": 1570, "died": 1636, "father": "Pauwels van Haverbeke", "mother": "Lievijne Jans"},
  {"name": "Joanna de Causmaecker", "sex": "f", "born": 1762, "died": 1807, "father": "Bernardus de Causmaecker", "mother":null},
  {"name": "Willem Haverbeke", "sex": "m", "born": 1668, "died": 1731, "father": "Lieven Haverbeke", "mother": "Elisabeth Hercke"},
  {"name": "Pieter Antone Haverbeke", "sex": "m", "born": 1753, "died": 1798, "father": "Jan Francies Haverbeke", "mother": "Petronella de Decker"},
  {"name": "Maria van Brussel", "sex": "f", "born": 1801, "died": 1834, "father": "Jan Frans van Brussel", "mother": "Joanna de Causmaecker"},
  {"name": "Angela Haverbeke", "sex": "f", "born": 1728, "died": 1734, "father": "Pieter Bernard Haverbeke", "mother": "Livina de Vrieze"},
  {"name": "Elisabeth Haverbeke", "sex": "f", "born": 1711, "died": 1754, "father": "Jan Haverbeke", "mother": "Maria de Rycke"},
  {"name": "Lievijne Jans", "sex": "f", "born": 1542, "died": 1582, "father":null, "mother":null},
  {"name": "Bernardus de Causmaecker", "sex": "m", "born": 1721, "died": 1789, "father": "Lieven de Causmaecker", "mother": "Livina Haverbeke"},
  {"name": "Jacoba Lammens", "sex": "f", "born": 1699, "died": 1740, "father": "Lieven Lammens", "mother": "Livina de Vrieze"},
  {"name": "Pieter de Decker", "sex": "m", "born": 1705, "died": 1780, "father": "Joos de Decker", "mother": "Petronella van de Steene"},
  {"name": "Joanna de Pape", "sex": "f", "born": 1654, "died": 1723, "father": "Vincent de Pape", "mother": "Petronella Wauters"},
  {"name": "Daniel Haverbeke", "sex": "m", "born": 1652, "died": 1723, "father": "Lieven Haverbeke", "mother": "Elisabeth Hercke"},
  {"name": "Lieven Haverbeke", "sex": "m", "born": 1631, "died": 1676, "father": "Pieter Haverbeke", "mother": "Anna van Hecke"},
  {"name": "Martina de Pape", "sex": "f", "born": 1666, "died": 1727, "father": "Vincent de Pape", "mother": "Petronella Wauters"},
  {"name": "Jan Francies Haverbeke", "sex": "m", "born": 1725, "died": 1779, "father": "Pieter Bernard Haverbeke", "mother": "Livina de Vrieze"},
  {"name": "Maria Haverbeke", "sex": "m", "born": 1905, "died": 1997, "father": "Emile Haverbeke", "mother": "Emma de Milliano"},
  {"name": "Petronella de Decker", "sex": "f", "born": 1731, "died": 1781, "father": "Pieter de Decker", "mother": "Livina Haverbeke"},
  {"name": "Livina Sierens", "sex": "f", "born": 1761, "died": 1826, "father": "Jan Sierens", "mother": "Maria van Waes"},
  {"name": "Laurentia Haverbeke", "sex": "f", "born": 1710, "died": 1786, "father": "Jan Haverbeke", "mother": "Maria de Rycke"},
  {"name": "Carel Haverbeke", "sex": "m", "born": 1796, "died": 1837, "father": "Pieter Antone Haverbeke", "mother": "Livina Sierens"},
  {"name": "Elisabeth Hercke", "sex": "f", "born": 1632, "died": 1674, "father": "Willem Hercke", "mother": "Margriet de Brabander"},
  {"name": "Jan Haverbeke", "sex": "m", "born": 1671, "died": 1731, "father": "Lieven Haverbeke", "mother": "Elisabeth Hercke"},
  {"name": "Anna van Hecke", "sex": "f", "born": 1607, "died": 1670, "father": "Paschasius van Hecke", "mother": "Martijntken Beelaert"},
  {"name": "Maria Sturm", "sex": "f", "born": 1835, "died": 1917, "father": "Charles Sturm", "mother": "Seraphina Spelier"},
  {"name": "Jacobus Bernardus van Brussel", "sex": "m", "born": 1736, "died": 1809, "father": "Jan van Brussel", "mother": "Elisabeth Haverbeke"}
])

// This makes sure the data is exported in node.js —
// `require("./path/to/ancestry.js")` will get you the array.
if (typeof module != "undefined" && module.exports)
	module.exports = ANCESTRY_FILE;
var ancestry = JSON.parse(ANCESTRY_FILE);

/*Используя набор данных из примера, подсчитайте среднюю разницу в
возрасте между матерями и их детьми (это возраст матери во время
появления ребёнка).*/
function average(array){
	function plus(a, b) { return a + b; }
	return array.reduce(plus) / array.length;
}

var byName = {};
ancestry.forEach(function(person){
	byName[person.name] = person;
});
//console.log(byName);

var dif = ancestry.filter(function(person){
	return byName[person.mother] != null;
}).map(function(person){
	return person.born-byName[person.mother].born;
});
console.log(average(dif));

//Подсчитайте средний возраст людей для каждого из столетий. Назначаем
//столетию людей, беря их год смерти, деля его на 100 и округляя:
//Math.ceil(person.died / 100).
function average(array){
	function plus(a, b) { return a + b; }
	return array.reduce(plus) / array.length;
}

//groupBy, абстрагирующая операцию группировки. Она должна принимать
//массив и функцию, которая вычисляет группу для элементов массива,
//и возвращать объект, который сопоставляет названия групп массивам
//членов этих групп.
function groupBy(array, func){
	var groups = {};
	array.forEach(function(element){
		var nameOfGroup = func(element);
		if (nameOfGroup in groups)
			groups[nameOfGroup].push(element);
		else 
		{
			//console.log(element);
			groups[nameOfGroup]=[element];
		}
	});
	return groups;
}

var personOfCenturies = groupBy(ancestry, function(person){
	return Math.ceil(person.died/100);
});
//console.log(personOfCenturies);

for (var century in personOfCenturies){
	var ages = personOfCenturies[century].map(function(person){
		return person.died - person.born;
	});
	//console.log(ages);
	console.log(century + ": " + average(ages));
}

//У массивов есть ещё стандартные методы every и some. Они принимают
//как аргумент некую функцию, которая, будучи вызванной с элементом
//массива в качестве аргумента, возвращает true или false. Так же,
//как && возвращает true, только если выражения с обеих сторон оператора
//возвращают true, метод every возвращает true, когда функция возвращает
//true для всех элементов массива. Соответственно, some возвращает true,
//когда заданная функция возвращает true при работе хотя бы с одним из
//элементов массива. Они не обрабатывают больше элементов, чем 
//необходимо – например, если some получает true для первого элемента,
//он не обрабатывает оставшиеся.

//Напишите функции every и some, которые работают так же, как эти методы,
//только принимают массив в качестве аргумента.
function every(array, func){
	for(var i=0; i<array.length; i++){
		if (!func(array[i]))
			return false;
	}
	return true;
}

function some(array, func){
	for(var i=0; i<array.length; i++){
		if (func(array[i]))
			return true;
	}
	return false;
}
console.log(every([NaN, NaN, NaN], isNaN));
console.log(every([NaN, NaN, 4], isNaN));
console.log(some([NaN, 3, 4], isNaN));
console.log(some([2, 3, 4], isNaN));

/*--------------------ТАЙНАЯ ЖИЗНЬ ОБЪЕКТОВ-------------------------*/
function Vector(x,y){
	this.x = x;
	this.y = y;
}
Vector.prototype.plus = function(v){
	return new Vector(this.x+v.x, this.y+v.y);
};
Vector.prototype.minus = function(v){
	return new Vector(this.x-v.x, this.y-v.y);
};
Object.defineProperty(Vector.prototype, "length", {
	get: function(){ return Math.sqrt(this.x*this.x+this.y*this.y); }
});
console.log(new Vector(1, 2).plus(new Vector(2, 3)));
console.log(new Vector(1, 2).minus(new Vector(2, 3)));
console.log(new Vector(3, 4).length);

//Создайте тип ячейки StretchCell(inner, width, height), соответствующий
//интерфейсу ячеек таблицы из этой главы. Он должен оборачивать другую
//ячейку (как делает UnderlinedCell), и убеждаться, что результирующая
//ячейка имеет как минимум заданные ширину и высоту, даже если внутренняя
//ячейка – меньше.
function repeat(string, times){
	var result = "";
	for (var i = 0; i < times; i++)
		result += string;
	return result;
}
function TextCell(text){
	this.text = text.split("\n");
}
TextCell.prototype.minWidth = function(){
	return this.text.reduce(function(width, line){
		return Math.max(width, line.length);
	}, 0);
};
TextCell.prototype.minHeight = function(){
	return this.text.length;
};
TextCell.prototype.draw = function(width, height){
	var result = [];
	for (var i = 0; i < height; i++) {
		var line = this.text[i] || "";
		result.push(line + repeat(" ", width - line.length));
	}
	return result;
};

function StretchCell(inner, width, height){
	this.inner = inner;
	this.width = width;
	this.height = height;
};
StretchCell.prototype.minWidth = function(){
	return Math.max(this.width, this.inner.minWidth());
};
StretchCell.prototype.minHeight = function(){
	return Math.max(this.height, this.inner.minHeight());
};
StretchCell.prototype.draw = function(width, height){
	return this.inner.draw(width, height);
};
var sc = new StretchCell(new TextCell("abc"), 1, 2);
console.log(sc.minWidth());
console.log(sc.minHeight());
console.log(sc.draw(3, 2));

/*Сделать функцию logFive, которая принимает объект-последовательность и
вызывает console.log для первых её пяти элементов – или для меньшего
количества, если их меньше пяти.
Затем создайте тип объекта ArraySeq, оборачивающий массив, и позволяющий
проход по массиву с использованием разработанного вами интерфейса. Создайте
другой тип объекта, RangeSeq, который проходит по диапазону чисел (его
конструктор должен принимать аргументы from и to).*/
function logFive(seq){
	for (var i=0; i<5; i++){
    if (!seq.next())
      break;
    console.log(seq.cur());
  }
}

function ArraySeq(array){
	this.post = -1;
	this.array = array;
}
ArraySeq.prototype.next = function(){
	if (this.post >= this.array.length-1)
    	return false;
	this.post++;
	return true;
};
ArraySeq.prototype.cur = function(){
	return this.array[this.post];
};

function RangeSeq(from, to){
	this.post = from-1;
	this.to = to;
}
RangeSeq.prototype.next = function(){
	if (this.post >= this.to)
		return false;
	this.post++;
	return true;
};
RangeSeq.prototype.cur = function(){
	return this.post;
};

logFive(new ArraySeq([1, 2]));
logFive(new RangeSeq(100, 1000));