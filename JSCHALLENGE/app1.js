//How to filter names if it starts with B using strings and variables

let ben = "Ben"
let emma = "Emma"
let bolu = "Bolu"

let Bnames = ""

// check the stored names



function newFunction() {
  if (ben[0] === "B") {
    Bnames = ben + " " + Bnames;
  }

  if (emma[0] === "B") {
    Bnames = emma + " " + Bnames;
  }

  if (bolu[0] === "B") {
    Bnames = bolu + " " + Bnames;
  }
}


newFunction();


console.log(Bnames.trim())

console.log('------------------------------------------------------')

//  implementing for loop on above

// even if array is empty it will still work except null which doesnt work with a length property

let names = ['emma', 'joy', 'edem']

let Enames = ""

for (let i = 0; i < names.length; i++) {

  if (names[i][0] === 'e')

    Enames = names[i] + " " + Enames
}

console.log(Enames)