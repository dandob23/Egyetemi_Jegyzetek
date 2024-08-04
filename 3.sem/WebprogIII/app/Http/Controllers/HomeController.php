<?php 

namespace App\Http\Controller;

use Illuminate\Http\Request;
use App\Models\Post;

class HomeController extends Controller
{
    public function index()
    {
        $recent = Post::orderBy('created_at', 'desc') ->paginate(9);

        
    }
}

