<!DOCTYPE html>
<html lang="en">
<head>
    <link rel="stylesheet" href="{{ asset('css/styles.css') }}">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    @include('layouts.app')
    <title>Saját profil</title>
    <header class="hatter1">
    <div class="card" style="background-color: #505050">
        <h1 style ="margin: 0px 40px;color:yellow">Saját profilom</h1>
    </div>


    </header>
</head>
<body class="hatter2 antialiased ml-4 text-center text-sm text-gray-500 sm:text-right sm:ml-0">
    <section>
    <div class="antialiased ml-4 text-center text-sm sm:text-right sm:ml-0" style="color:yellow">
        <h3>    Felhasználónév:             {{ Auth::user()->name }}</h3>
        <button class ="show-form-btn" style="background-color: #404040" onclick="showForm()">Megváltoztatnád a felhasználóneved?  
        <div id="form">
            <form class="form-hidden" method=  "PUT" action="{{ route('users.update', Auth::user()->id) }}">
                    @csrf
                    <input type="text" name="name" value="{{ Auth::user()->name }}">
                    <input type="submit" value="Módosít">
                </form></div></button> 
        </div></h2>
        <h3 style="color:yellow">    Email cím:                  {{ Auth::user()->email }}</h3>
        <h3 style="color:yellow">    Fiókom készítésének ideje:  {{ Auth::user()->created_at }}</h3>
        <h3 style="color:yellow">    Pénztárca jelenleg:         {{ Auth::user()->money }}
            
        </h3>
        <h3 style="color:yellow">    Telefonszáma:         {{ Auth::user()->mobile_number }}</h3>
    </div>
    <div>@include('livetable')</div>
    <h2>
        <a href="livetable" style="color: inherit;text-decoration: none;color:yellow">Saját járműveim</a>
    </h2>
</section>
</body>
</html> 
