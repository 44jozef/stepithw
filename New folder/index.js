const fs = require('fs');
const readline = require('readline');

const booksFile = './books.json';

if (!fs.existsSync(booksFile)) {
  fs.writeFileSync(booksFile, JSON.stringify([]));
}

const readBooksFromFile = () => {
  const data = fs.readFileSync(booksFile);
  return JSON.parse(data);
};

const saveBooksToFile = (books) => {
  fs.writeFileSync(booksFile, JSON.stringify(books, null, 2));
};

const generateId = (books) => {
  return books.length > 0 ? Math.max(...books.map(book => book.id)) + 1 : 1;
};

const createBook = (title, author, year, genre) => {
  const books = readBooksFromFile();
  const id = generateId(books);
  const newBook = { id, title, author, year, genre };
  books.push(newBook);
  saveBooksToFile(books);
  console.log('Книга добавлена:', newBook);
};

const readBooks = () => {
  const books = readBooksFromFile();
  console.log('Список книг:');
  books.forEach(book => {
    console.log(`ID: ${book.id}, Название: ${book.title}, Автор: ${book.author}, Год издания: ${book.year}, Жанр: ${book.genre}`);
  });
};

const updateBook = (id, title, author, year, genre) => {
  const books = readBooksFromFile();
  const bookIndex = books.findIndex(book => book.id === id);
  
  if (bookIndex === -1) {
    console.log('Книга не найдена.');
    return;
  }

  books[bookIndex] = { id, title, author, year, genre };
  saveBooksToFile(books);
  console.log('Книга обновлена:', books[bookIndex]);
};

const deleteBook = (id) => {
  let books = readBooksFromFile();
  const bookIndex = books.findIndex(book => book.id === id);

  if (bookIndex === -1) {
    console.log('Книга не найдена.');
    return;
  }

  books = books.filter(book => book.id !== id);
  saveBooksToFile(books);
  console.log(`Книга с ID ${id} удалена.`);
};

const rl = readline.createInterface({
  input: process.stdin,
  output: process.stdout
});

const askQuestion = (query) => new Promise(resolve => rl.question(query, resolve));

const main = async () => {
  while (true) {
    console.log('\n--- Меню ---');
    console.log('1. Добавить книгу');
    console.log('2. Посмотреть книги');
    console.log('3. Обновить книгу');
    console.log('4. Удалить книгу');
    console.log('5. Выход');

    const choice = await askQuestion('Выберите действие: ');

    if (choice === '1') {
      const title = await askQuestion('Введите название книги: ');
      const author = await askQuestion('Введите автора: ');
      const year = await askQuestion('Введите год издания: ');
      const genre = await askQuestion('Введите жанр: ');
      createBook(title, author, year, genre);
    } else if (choice === '2') {
      readBooks();
    } else if (choice === '3') {
      const id = parseInt(await askQuestion('Введите ID книги для обновления: '), 10);
      const title = await askQuestion('Введите новое название книги: ');
      const author = await askQuestion('Введите нового автора: ');
      const year = await askQuestion('Введите новый год издания: ');
      const genre = await askQuestion('Введите новый жанр: ');
      updateBook(id, title, author, year, genre);
    } else if (choice === '4') {
      const id = parseInt(await askQuestion('Введите ID книги для удаления: '), 10);
      deleteBook(id);
    } else if (choice === '5') {
      rl.close();
      break;
    } else {
      console.log('Неверный выбор. Попробуйте снова.');
    }
  }
};

main();
