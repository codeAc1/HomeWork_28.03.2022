////(function load_trainers() {
////    let load_btn = document.getElementById("load_more")
////    load_btn.addEventListener("click", function (e) {
////        e.preventDefault();
////        let url = this.getAttribute("href")
////        $.ajax({
////            url: url,
////        })
////    })
////}());

let btn = document.querySelector("#load_more");
btn.addEventListener("click", function (e) {
    e.preventDefault();
    let url = this.getAttribute("href")
    fetch(url)
        .then(response => response.json())
        .then(data => {

            var x = ""
            data.forEach(user => {
                console.log(user)
                x += `<div class="col-lg-4 col-md-6 d-flex align-items-stretch">
                        <div class="member">
                            <img src="assets/img/trainers/${user.image}" class="img-fluid" alt="">
                            <div class="member-content">
                                <h4>${user.name} ${user.surName}</h4>
                                <span>${user.category.name}</span>
                                <p>
                                    ${user.info}
                                </p>
                                <div class="social">
                                    <a href="${user.twitter}" target="_blank"><i class="bi bi-twitter"></i></a>
                                    <a href="${user.facebook}" target="_blank"><i class="bi bi-facebook"></i></a>
                                    <a href="${user.instagram}" target="_blank"><i class="bi bi-instagram"></i></a>
                                    <a href="${user.linkedin}" target="_blank"><i class="bi bi-linkedin"></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
            `
            })
            document.getElementById("Trainers").innerHTML += x
        })
        .catch(error => console.log(error))


})

let cards = document.querySelector(".card ")

console.log(cards)