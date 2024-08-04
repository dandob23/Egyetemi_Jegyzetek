<?php

use Illuminate\Support\Facades\Route;
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

Auth::routes();
Route::get('/', function () {
    return view('welcome');
})->name('welcome');   

Route::get('/home', function () {
    return view('home');
})->name('home');  

Route::get('/profile', function () {
    return view('profile');
})->name('profile');   

Route::get('/livetable', function () {
    return view('livetable');
})->name('livetable');   

Route::get('/home', [App\Http\Controllers\HomeController::class, 'index'])->name('home');

Route::put('/profile/usernameChange', 'UserController@update')->name('users.update');
Route::post('/profile/addMoney', 'UserController@addMoney')->name('profile.addMoney');


/*Route::get('livetable', 'LiveTable\LiveTable@index')->name('livetable');*/
//Route::get('/livetable/fetch_data', 'LiveTable@fetch_data');

//Route::get('/livetable/fetch_data', [LiveTable::class, 'fetch_data']);
Route::post('livetable/add_data', 'LiveTable\LiveTable@add_data')->name('livetable.add_data');
Route::post('livetable/update_data', 'LiveTable\LiveTable@update_data')->name('livetable.update_data');
Route::post('livetable/delete_data', 'LiveTable\LiveTable@delete_data')->name('livetable.delete_data');


Route::get('live_search', 'LiveSearch\LiveSearch@index')->name('live_search');
Route::get('live_search/action', 'LiveSearch\LiveSearch@action')->name('live_search.action');
