@extends('layout')
@section('content')
<style>
 .uper {
 margin-top: 40px;
 }
</style>
    <a href="books/create">Thêm Mới</a>
    <table id="datatable" class="table table-striped table-bordered">
        <thead>
                <th>ID</th>
                <th>Ten Sach</th>
                <th>So ISBN</th>
                <th>Giá</th>
                <th>Thao tác</th>

        </thead>
        <tbody>
            
            @foreach ($books as $item)
            <tr>
                <td>{{$item->id}}</td>
                <td>{{$item->book_name}}</td>
                <td>{{$item->isbn_no}}</td>
                <td>{{$item->book_price}}</td>
                <td>
                    <a href="{{ route('books.edit',['id' => $item->id]) }}" type="button" class="btn btn-primary">Sửa</a>
                    <a href="{{ route('books.xoa',['id' => $item->id]) }}" type="button" class="btn btn-primary">Xóa</a>
                </td>
                
            </tr>
            @endforeach
            
        </tbody>
    </table>
@endsection
