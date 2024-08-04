<?php
namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use DB;

class LiveTable extends Controller
{
    public function index()
    {
        return view('livetable');
    }

    public function fetch_data(Request $request)
    {
        if($request->ajax())
        {
            $data = DB::table('vehicle')->orderBy('user_id','desc')->get();
            echo json_encode($data);
        }
    }

    public function add_data(Request $request)
    {
        if($request->ajax())
        {
            $data = array(
                'vehicle_type'    =>  $request->vehicle_type,
                'vehicle_brand'     =>  $request->vehicle_brand,
                'license_plate'    =>  $request->license_plate,
                'km'    =>  $request->km,
                'quality'    =>  $request->quality,
                'picture'    =>  $request->picture,
            );
            $id = DB::table('vehicle')->insert($data);
            if($id > 0)
            {
                echo '<div class="alert alert-success">Adat feltöltve</div>';
            }
        } 
    }

    public function update_data(Request $request)
    {
        if($request->ajax())
        {
            $data = array(
                $request->column_name       =>  $request->column_value
            );
            DB::table('vehicle')
                ->where('user_id', $request->id)
                ->update($data);
            echo '<div class="alert alert-success">Adat frissítve</div>';
        }
    }

    public function delete_data(Request $request)
    {
        if($request->ajax())
        {
            DB::table('vehicle')
                ->where('user_id', $request->id)
                ->delete();
            echo '<div class="alert alert-success">Adat törölve</div>';
        }
    }
}
