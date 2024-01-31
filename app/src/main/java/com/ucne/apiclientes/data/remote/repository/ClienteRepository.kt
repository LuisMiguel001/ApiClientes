package com.ucne.apiclientes.data.remote.repository

import com.ucne.apiclientes.data.ClienteApi
import com.ucne.apiclientes.data.remote.Cliente
import java.util.concurrent.Flow
import javax.inject.Inject

class ClienteRepository  @Inject constructor(
    private val clientes : ClienteApi
){
    suspend fun getListClientes(): List<Cliente> {
        return clientes.GetList()
    }

    suspend fun getClientes(id: Int): Cliente {
            return clientes.GetClientes(id)
    }
}