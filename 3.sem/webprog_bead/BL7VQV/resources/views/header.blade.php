<head>
    <link rel="stylesheet" href="{{ asset('css/styles.css') }}">
<nav>
<div class ="container">
<div class="row justify-content-center">

    <div class ="card centered yellow">
    <div class ="links">
    <a href="profile" style="color: inherit;text-decoration: none;">Profil</a>
    <a href="rentavehicle" style="color: inherit;text-decoration: none;">Rent-a-vehicle</a>
    <li class="nav-item dropdown">
        <a id="navbarDropdown" class="nav-link dropdown-toggle" href="#" role="button" data-bs-toggle="dropdown" 
        aria-haspopup="true" aria-expanded="false">
            Keresés
        </a>
        <div  class="dropdown-menu dropdown-menu-end" aria-labelledby="navbarDropdown">
            @include('live_search')
        </div>
    </li>
    </div>
    </div>
    </div>    
</div>    

</nav>
</head>