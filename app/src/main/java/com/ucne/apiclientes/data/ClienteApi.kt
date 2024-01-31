package com.ucne.apiclientes.data

import com.ucne.apiclientes.data.remote.Cliente
import retrofit2.Response
import retrofit2.http.Body
import retrofit2.http.GET
import retrofit2.http.POST
import retrofit2.http.Path

interface ClienteApi {
    @GET("ClientesController")
    suspend fun GetList(): List<Cliente>

    @GET("ClientesController/{id}")
    suspend fun GetClientes(@Path("id") id: Int): Cliente
}