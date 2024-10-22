const hamburgerBtn = document.querySelector(".hamburger");
const menuList = document.querySelector(".menu-list");

const copyrightEle = document.querySelector(".copyright");

const hamburgerEvent = () => {
  let isOpened = false;
  hamburgerBtn.addEventListener("click", (e) => {
    e.preventDefault();
    isOpened = !isOpened;

    if (isOpened) {
      menuList.classList.add("show");
      hamburgerBtn.src = "assets/images/icon-close.svg";
      hamburgerBtn.classList.add("spin");
    } else {
      menuList.classList.remove("show");
      hamburgerBtn.src = "assets/images/icon-hamburger.svg";
      hamburgerBtn.classList.add("spin");
    }
    hamburgerBtn.classList.remove("spin");
  });
};

copyrightEle.innerText = `Copyright ${new Date().getFullYear()}. All Rights Reserved`;
hamburgerEvent();
