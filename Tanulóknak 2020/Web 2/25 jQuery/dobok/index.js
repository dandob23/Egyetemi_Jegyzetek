let dobokszama = document.querySelectorAll(".dob").length;

for (let i = 0; i < dobokszama; i++) {
  document.querySelectorAll(".dob")[i].onclick = function() {
    hangadas(this.innerHTML);
    animacio(this.innerHTML);
  };
}

document.onkeydown = function(event) {
  hangadas(event.key);
  animacio(event.key);
};


function hangadas(bill) {
  let hang;
  switch (bill) {
    case "w":
      hang = new Audio("sounds/tom-1.mp3");
      hang.play();
      break;

    case "a":
      hang = new Audio("sounds/tom-2.mp3");
      hang.play();
      break;

    case "s":
      hang = new Audio('sounds/tom-3.mp3');
      hang.play();
      break;

    case "d":
      hang = new Audio('sounds/tom-4.mp3');
      hang.play();
      break;

    case "j":
      hang = new Audio('sounds/snare.mp3');
      hang.play();
      break;

    case "k":
      hang = new Audio('sounds/crash.mp3');
      hang.play();
      break;

    case "l":
      hang = new Audio('sounds/kick-bass.mp3');
      hang.play();
      break;

    default:
  }
}

function animacio(bill) {
  if (!"wasdjkl".includes(bill))
    return;
  let gomb = document.querySelector("#" + bill);
  gomb.classList.add("pressed");
  setTimeout(function() {
    gomb.classList.remove("pressed");
  }, 200);
}
