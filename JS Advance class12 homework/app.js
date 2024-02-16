function Library(name,books,address){
    this.name = name
    this.books = !books ? [] : books
    this.address = address
    this.numberOfMembers = this.books.length * 15
    //couldn't get this to work 
    this.printBooks = function(){
        this.books.forEach(book => console.log(book))
    }
    this.addBook = function(book){
       let newBook = Object.create(book)
       this.books.push(newBook)
    }
}

function Book(title,genre,libraries , authors){
    this.title = title
    this.genre = genre
    this.libraries = !libraries ? [] :libraries
    this.authors = !authors ? [] :authors
    this.addLibrary = function(library){
        this.libraries.push(library)
        library.books.push(this)
    }
    // mutateing the original Array
    // returning the mutated array without the removed Books 
    this.removeLibrary = function(library){
        const index = this.libraries.indexOf(library)
        if(index !== -1){
            this.libraries.splice(index , 1)
        }
        const bookIndex = library.books.indexOf(this);
        if (bookIndex !== -1) {
            library.books.splice(bookIndex, 1);
            }
    }
}

function Author(firstName, lastName, yearOfBirth,){
    this.firstName = firstName
    this.lastName = lastName
    this.yearOfBirth = yearOfBirth
    this.books = []
    this.currentBooks = null
    this.startBook = function(book){
        if(this.currentBooks != null){
            this.books.push(this.currentBooks)
        }
        this.currentBooks = book

    }    

}

let removedBooks = []

let libraryOne = new Library("Litertaura MK" , [] , "Skopje")
let book = new Book("Lord Of The Rings" , "Fantasy" , [] , [] )
let book2 = new Book("GOT" , "Fantasy/action" , [] , [] )
let book3 = new Book("Wheel of Time" , "Fant" , [] , [] )
let book4 = new Book("Harry Potter" , "Magical" , [] , [] )
let authorOne = new Author("Nekoj Avtor", "Nekoe Prezime" , 1998)

libraryOne.addBook(book4)


authorOne.startBook(book)
console.log(authorOne)
authorOne.startBook(book2)
authorOne.startBook(book3)

book.addLibrary(libraryOne)
console.log(libraryOne)
book2.addLibrary(libraryOne)
book3.addLibrary(libraryOne)

libraryOne.printBooks()

console.log(libraryOne.books)


book2.removeLibrary(libraryOne)
book.removeLibrary(libraryOne)

console.log(libraryOne)

console.log(removedBooks)

