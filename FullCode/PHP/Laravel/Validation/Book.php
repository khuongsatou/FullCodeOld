<?php

namespace App;

use Illuminate\Database\Eloquent\Model;
use Illuminate\Database\Eloquent\SoftDeletes;
class Book extends Model
{
    use SoftDeletes;
    protected $table = "books";
    protected $fillable = ['book_name','isbn_no','book_price'];
}
