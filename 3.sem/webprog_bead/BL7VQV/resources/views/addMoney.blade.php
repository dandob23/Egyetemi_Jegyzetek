@extends('layouts.app')

@section('content')
    <div class="container">
        <div class="row">
            <div class="col-md-8 offset-md-2">
                <div class="card">
                    <div class="card-header">Pénz hozzáadása</div>

                    <div class="card-body">
                        <form action="{{ route('addMoney') }}" method="POST">
                            @csrf
                            <label for="money">Hozzáadni kívánt érték:</label>
                            <input type="number" name="money" id="money">
                            <input type="submit" value="Hozzáad">
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
@endsection
