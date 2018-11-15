//Refactoring app1.js


function firstCharacterFilter(elements, character) {

  let enames = ''

  for (let i = 0; i < elements.length; i += 1) {

    if (elements[i][0] === character) {

      enames = elements[i] + " " + enames
    }

  }

  return enames

}


//checking above function on a variable of animals

let animals = ['dog', 'pig', 'rat', 'monkey', 'lion', 'mouse']

// print out result

console.log(firstCharacterFilter(animals, 'r'))