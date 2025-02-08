document.getElementById("categorie").addEventListener("change", function() {
    var selectedCategory = this.value;
    var rectangles = document.querySelectorAll(".rectangle");

    rectangles.forEach(function(rectangle) {
        if (rectangle.id === selectedCategory || selectedCategory === "all") {
            rectangle.style.display = "flex";
        } else {
            rectangle.style.display = "none";
        }
    });
});
