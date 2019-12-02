<?php

/*
|--------------------------------------------------------------------------
| Web Routes
|--------------------------------------------------------------------------
|
| Here is where you can register web routes for your application. These
| routes are loaded by the RouteServiceProvider within a group which
| contains the "web" middleware group. Now create something great!
|
*/

/*
    Nguyễn Văn Khương
    0306171362
    CDTH17PMA

*/
Route::get('/',function(){
    return View('wellcome');
});


Route::prefix('books')->group(function(){
    Route::name('books.')->group(function(){
        Route::get('/','BookController@index')->name('index');
        Route::get('/create','BookController@create')->name('create');
        Route::post('/store','BookController@store')->name('store');
        Route::get('/edit/{id}','BookController@edit')->name('edit');
        Route::post('/edit/{id}','BookController@update')->name('update');
        Route::get('/xoa/{id}','BookController@destroy')->name('xoa');
    });
});
