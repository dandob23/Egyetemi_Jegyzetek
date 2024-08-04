<?php

use Illuminate\Database\Migrations\Migration;
use Illuminate\Database\Schema\Blueprint;
use Illuminate\Support\Facades\Schema;

return new class extends Migration
{
    /**
     * Run the migrations.
     *
     * @return void
     */
    public function up()
    {
        Schema::create('vehicle', function (Blueprint $table) {
            $table->bigIncrements('user_id');
            $table->foreign('user_id')->references('id')->on('users');
            $table->integer('vehicle_id');
            $table->string('vehicle_type');
            $table->string('vehicle_brand')->nullable();
            $table->string('license_plate')->nullable();
            $table->timestamp('uploaddate')->nullable();
            $table->integer('km');
            $table->enum('quality',['1','2','3','4','5']);
            $table->binary('picture')->nullable();
        });
    }

    /**
     * Reverse the migrations.
     *
     * @return void
     */
    public function down()
    {
        Schema::dropIfExists('vehicle');
    }
};
