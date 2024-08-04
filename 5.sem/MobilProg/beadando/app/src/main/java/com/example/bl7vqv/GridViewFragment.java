package com.example.bl7vqv;

import android.os.Bundle;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.GridView;

public class GridViewFragment extends Fragment {


    public View onCreateView(@NonNull LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        View rootView = inflater.inflate(R.layout.fragment_grid_view, container, false);

        GridView gridView = rootView.findViewById(R.id.grid_view);
        //12. feladat
        String[] data = {"Elem 1", "Elem 2", "Elem 3", "Elem 4", "Elem 5"};

        ArrayAdapter<String> adapter = new ArrayAdapter<>(getActivity(), R.layout.list_item, R.id.text_view, data);
        gridView.setAdapter(adapter);
        //------------------//

        //13. feladat
        String[] data2 = getResources().getStringArray(R.array.grid_items);

        ArrayAdapter<String> adapter2 = new ArrayAdapter<>(getActivity(), R.layout.list_item, R.id.text_view, data2);
        gridView.setAdapter(adapter2);
        //------------------//

        return rootView;
    }
}