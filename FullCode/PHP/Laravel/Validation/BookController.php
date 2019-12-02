<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Book;

class BookController extends Controller
{
    /**
     * Display a listing of the resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        $books = Book::all();
        return view('index', compact('books'));
    }


    /**
     * Show the form for creating a new resource.
     *
     * @return \Illuminate\Http\Response
     */
    public function create()
    {
        return view('create');
    }
public function store(Request $request)
{
    $validatedData = $request->validate([
    'book_name' => 'required|max:255',
    'isbn_no' => 'required|alpha_num',
    'book_price' => 'required|numeric',
    ]);
    $book = Book::create($validatedData);
    return redirect('/books')->with('success', 'Luu thanh cong!');
}

    /**
     * Display the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function show($id)
    {
        //
    }

    /**
     * Show the form for editing the specified resource.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function edit($id)
    {
        $book = Book::findOrFail($id);
        return view('edit', compact('book'));
    }
    public function update(Request $request, $id)
    {
        $validatedData = $request->validate([
        'book_name' => 'required|max:255',
        'isbn_no' => 'required|alpha_num',
        'book_price' => 'required|numeric',
        ]);
        Book::whereId($id)->update($validatedData);
        return redirect('/books')->with('success', 'Cap nhat thanh cong!');
    }
    /**
     * Remove the specified resource from storage.
     *
     * @param  int  $id
     * @return \Illuminate\Http\Response
     */
    public function destroy($id)
    {
        $book = Book::findOrFail($id);
        $book->delete();
        return redirect('/books')->with('success', 'Xoa thanh cong!');
    }

}
