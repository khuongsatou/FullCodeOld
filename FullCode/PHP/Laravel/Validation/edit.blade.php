@extends('layout')
@section('content')
<style>
 .uper {
 margin-top: 40px;
 }
</style>
<div class="card uper">
 <div class="card-header">
    <h3>Edit</h3>
</div>
        <div class="card-body">
            @if ($errors->any())
            <div class="alert alert-danger">
                <ul>
                @foreach ($errors->all() as $error)
                <li>{{ $error }}</li>
                @endforeach
                </ul>
            </div><br />
    @endif
        
        <form method="post" action="{{ route('books.update',['id'=>($book->id)]) }}">    
       
            <div class="form-group">
                @csrf
                <label for="name">Ten sach :</label>
                <input type="text" class="form-control" name="book_name"
                @if(isset($book))
                    value="{{$book->book_name}}"
                @endif
                />
            </div>
            <div class="form-group">
                <label for="price">So ISBN :</label>
                <input type="text" class="form-control" name="isbn_no"
                @if(isset($book))
                value="{{$book->isbn_no}}"
                @endif
                />
            </div>
            <div class="form-group">
                <label for="quantity">Gia :</label>
                <input type="text" class="form-control" name="book_price"
                @if(isset($book))
                value="{{$book->book_price}}"
                @endif
                />
            </div>
            <button type="submit" class="btn btn-primary">Them moi</button>
        </form>
    </div>
</div>
@endsection
