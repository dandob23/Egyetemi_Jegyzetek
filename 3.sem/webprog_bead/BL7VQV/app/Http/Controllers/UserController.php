<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use App\Providers\RouteServiceProvider;
use App\Models\User;
use DB;
class UserController extends Controller
{
    public function update(Request $request, $id)
    {
        $user = User::find($id);
        $user->name = $request->input('name');
        $user->email = $request->input('email');
        $user->save();
    }

    public function addMoney(Request $request)
    {

        $user = Auth::user();
        
        $user->money = $user->money + $request->input('money');

        $user->save();

        return redirect()->route('profile');
    }
}