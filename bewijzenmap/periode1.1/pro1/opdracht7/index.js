var answer;
var opgaven = 0;
var goed = 0;
var fout = 0;
var input = document.getElementById("mijnantwoord");
var wrapper = document.getElementById('wrapper');
var goedOfFout = document.getElementById('GoedOfFout');
var goedEnfout = document.getElementById('AantalGoedEnFout');
var IMG = document.getElementById('GoedOfFoutIMG');
var RekenenTXT = document.getElementById("RekenTXT");
var sum = document.getElementById("Sum");
input.addEventListener("keyup", keyPressed);

makeSumAnimation();
updateGoedAndFout();
function makeSum() {
  opgaven++;
  var numberA = getRandomInt(10);
  var numberB = getRandomInt(10);
  document.getElementById("SumNumberOne").innerHTML = "" + numberA;
  document.getElementById('SumNumberTwo').innerHTML = "" + numberB;

  answer = numberA * numberB;
  console.log(answer);
}

var count = 0;

function makeSumAnimation() {
  if (count <= 20) {
    setTimeout(function () {
    count += 1;
    var numberA = getRandomInt(10);
    var numberB = getRandomInt(10);
    var color = ["red", "blue", "orange", "green", "purple", "fuchsia", "gray", "yellow", "darkred", "lime"];
    document.getElementById("SumNumberOne").style.color = color[numberA];
    document.getElementById('SumNumberTwo').style.color = color[numberB];

    document.getElementById("SumNumberOne").innerHTML = "" + numberA;
    document.getElementById('SumNumberTwo').innerHTML = "" + numberB;

    makeSumAnimation();
    return;
}, 50);
} else {
  count = 0;
  makeSum();
  }
}
function keyPressed() {
  if (event.keyCode === 13) {
    event.preventDefault();
    if (input.value == answer) {
      console.log("goed");
      IMG.src="images/goed.png";
      IMG.classList.add("GoedOfFoutIMGAnimation");
      var goedAudio = new Audio('sounds/right.wav');
      goedAudio.play();
      wrapper.classList.remove("WrapperFOUT");
      wrapper.classList.add("WrapperGOED");
      goed++;
    } else {
      IMG.src="images/fout.png";
      IMG.classList.add("GoedOfFoutIMGAnimation");
      var foutAudio = new Audio('sounds/wrong.wav');
      console.log("fout");
      foutAudio.play();
      wrapper.classList.remove("WrapperGOED");
      wrapper.classList.add("WrapperFOUT");
      fout++;
    }
    input.value = "";
    waiting();
  }
}
function waiting() {
  setTimeout(function () {
    IMG.classList.remove("GoedOfFoutIMGAnimation");
    wrapper.classList.remove("WrapperGOED");
    wrapper.classList.remove("WrapperFOUT");
    makeSumAnimation();
    updateGoedAndFout();
}, 2000);
}
function getRandomInt(max) {
  return Math.floor(Math.random() * Math.floor(max));
}
function updateGoedAndFout() {
  goedEnfout.innerHTML = "Aatal goed:" + goed + "  Aantal fout:" + fout;
  document.getElementById("AantalOpgaven").innerHTML = "Opgaven gedaan: " + opgaven;
}
